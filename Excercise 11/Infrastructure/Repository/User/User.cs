

using Core.Domain.Model;

public class User : IUser
{
    private readonly Context db; 
    public User(Context _db){
        db=_db;
    }

    public void AddUser(MUser mUser)
    {
       Tbl_User user=new Tbl_User();
       user.userName=mUser.userName;
       user.password=mUser.password;
       db.Tbl_Users.Add(user);
       db.SaveChanges();
    }
}
