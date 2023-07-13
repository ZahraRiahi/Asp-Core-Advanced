using Microsoft.AspNetCore.Mvc;
using Kavenegar;
public class LoginController:Controller
{
    private readonly Context db;
    public static string x;

    public LoginController(Context _db){
        db=_db;
    }
     public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SendCode(String Phone)
     {
         Random rnd=new Random();  
         string number=rnd.Next(1000,999).ToString();
            KavenegarApi Api = new KavenegarApi("4632492B4141306C4E4A7648766F71673456375458695246586C36654B2B49504C624F4142336D643136673D");
                var message = Api.Send(Phone, number, "demo");
                User user=new User();
                user.Phone=Phone;
                user.Code=number;
                db.Users.Add(user);
                db.SaveChanges();
                x=Phone;
                return RedirectToAction("code");
    }
      public IActionResult Check(String Code)
    {
        var user=db.Users.Where(a=>a.Code==Code && a.Phone==x).FirstOrDefault();
        if(user!=null){
            return RedirectToAction("Index","Home");
        }
        else{
         return RedirectToAction("Code");

        }
    }


}