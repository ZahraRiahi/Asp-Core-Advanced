 
 ﻿using System;
 using Kavenegar;

class Program
{
    static void Main(string[] args)
    {
                KavenegarApi Api = new KavenegarApi("4632492B4141306C4E4A7648766F71673456375458695246586C36654B2B49504C624F4142336D643136673D");
                var message = Api.Send("1008663", "09379385037", "Hi");

        
            Console.ReadLine();
    }
}