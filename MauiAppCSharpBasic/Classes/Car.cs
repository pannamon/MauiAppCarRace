using System;
using System.ComponentModel.DataAnnotations;

namespace MauiAppCSharpBasic.Classes; //projectname.classfoldername

public class Car
{    
   public string Model ;  //ประกาศตัวแปรในคลาส
   public string Color ;
   public double speed ;
   public double fuel;
   public double TotalMile;
   public double UseFuelRate;  //xxx mile per liter
   //ถ้าเขียนเป็น private = เรียกใช้ได้แค่ในclass นี้ ไม่สามารถไปเรียกใช้ได้ใน mainpage.cs


   public Car(string Model , double speed , double fuel )
   {
     this.Model = Model;
     this.speed = speed;
     this.fuel = fuel;
   }
   public void Run(double mile) //method
   {
      //this.TotalMile = this.TotalMile + distance;
      this.TotalMile += mile;   //ทุกครั้งที่วิ่ง น้ำมันต้องลดลง 
      var use_fuel = mile* this.UseFuelRate ; //var ประกาศตัวแปรใหม่ ไม่ระบุtype
      this.fuel = this.fuel - use_fuel;
   }
   
   public uint TimeUseForRun(double mile)
   {
      var timeuse = mile/speed;
      this.Run(mile);
      return Convert.ToUInt16(timeuse);
   }
   public string ShowInfo()
   {
     var info =$"Model {this.Model} \n Total mile : {this.TotalMile} \n Fuel : {this.fuel}";
     return info;

   }

}

