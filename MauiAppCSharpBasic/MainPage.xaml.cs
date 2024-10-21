using System.Net.Security;
using MauiAppCSharpBasic.Classes;

namespace MauiAppCSharpBasic;

public partial class MainPage : ContentPage
{
	//int count = 0;
    Car audi;
	Car nissan;
    bool isFinish= false; //สร้างขึ้นเพื่อให้รถวิ่งกลับที่เดิม
	public MainPage()
	{
		InitializeComponent(); 

		audi = new Car("A1" , 220 , 10);  //เวลาที่runจะมาเรียก object ที่ตรงนี้
		audi.UseFuelRate = 10;
	    nissan = new Car("S1" , 180 , 3);
		nissan.UseFuelRate = 8;

	}
    
  private void Button_Clicked(object sender, EventArgs e)
  {
	if(!this.isFinish)
	{
	  var screenWidth =Application.Current.MainPage.Width; //ตามความกว้างของหน้าจอ
	 // ImageCar1.TranslateTo(screenWidth-100,0,2000,Easing.Linear); //แกน x(ที่-100คือให้ลบตามความกว้างรูปไม่งั้นวิ่งจนสุดหายไปเลย),y,เวลาที่ใช้วิ่ง,
	 
	  this.AudiRun(screenWidth);
	  this.NissanRun(screenWidth);
	  this.myLabel.Text= audi.ShowInfo() + "\n" + nissan.ShowInfo();
	  this.isFinish = true;
	}
	else
	{
	  ImageCar1.TranslateTo(0,0,0,Easing.Linear);	//ให้วิ่งกลับมาที่เดิม
	  ImageCar2.TranslateTo(0,0,0,Easing.Linear);
	  this.isFinish = false;
	}
	//audi.Run(10);
	//nissan.Run(5);
	//myLabel.Text = audi.ShowInfo() +"\n"+ nissan.ShowInfo();

  }

	// c# basic//private void Button_Clicked(object sender, EventArgs e)
   // {
		//myLabel.Text="Hello C#!!!"; 
		//int age;
		/*
		int age = 25;
		string name = "PingPing";
		float gpa = 3.75f;
		bool isGraduated = false;
		double pi = 3.14104198432;
        int score = 60;
		*/

        /* if else 1
		if (gpa >= 3.75)
		{
			myLabel.Text="เกียรตินิยม";
		}
		else {
			myLabel.Text ="Good";
		}
        */
       
	   /*if else if else
	   if(score>80)
	   {
		 myLabel.Text="A";
	   }
	    else if (score > 70)
	   {
		 myLabel.Text="B";
	   }
        else if (score > 60)
	   {
		 myLabel.Text="c";
	   }
	   else if (score > 50)
	   {
		myLabel.Text="D";
	   }
	   else 
	   {
		myLabel.Text="F";
	   }
	   */

      // string star="";
	   
	  /* draw stars
	   *
	   **
	   ***
	   ****
	   *****
	   */
	  /* for(int i=0 ; i<5; i++) */ // for loop i++ > i=i+1
	  /*while loop
	  
	  int i=0;

	   while( i<10 )
	   {
		 for(int j=0 ; j<=i ; j++)
         {
			star=star+"*";
		 }
		 //star =star+"*\n";
		 star+="\n";
		 //i = i+1;
		 i++;
		 
	   
	   
	   }

	   myLabel.Text=star; */
     
	   /*Array
	 int[] score = { 80 , 90 , 71 , 55 , 67 };
	 string[] name = {"a","b","c","d","e"};
	 double[] gpa ={3.75,2.5,3.44,2.87,2.10};

    /*for loop array
    string text="";
    for (int i=0 ; i<score.Length ;i++)
	{

       text = text + score[i] + " " ;

	}

	 //myLabel.Text = $"My score is{score[0]}"; //[index] ,before use for  loop
	 myLabel.Text = text; */
       /*foreach
	string text ="";
	foreach(var s in score)
	{
     text += $"score { s } , " ;
	}
    
	myLabel.Text = text; */
     //parameter 
	   // myLabel.Text = GetGreetingMessage("pingping",80);
       //UpdateLabelText("pingping",70);
	   /* UpdateLabelText();
    }

	private string GetGreetingMessage(string name) //method ใช้เรียกใช้ได้หลายครั้ง 1 reference คือถูกเรียกใช้ไป 1 ครั้ง
	{
		return $"Hello {name}";
	}
	private string GetGreetingMessage()  //ชื่อmethod ซ้ำกันได้แต่parameterซ้ำกันไม่ได้ และจะถูกใช้methodไหนก็ดูที่ค่าparameter ถ้าไม่มีค่าparameterก็ใช้methodที่ไม่ได้ระบุparameter
	{
        return $"Hello unknown";
	}
    private string GetGreetingMessage(string name,int score)	
	{
       return $"Hello {name} your is score {score}";
	}

	private void UpdateLabelText(string name , int score) //void = no return type
	{
      myLabel.Text = $"Hello {name} your is score {score}";
	}
	private void UpdateLabelText()
	{
      string[] name ={"a","b","c"};
	  int[] score ={5,10,15};
	  string text = "";
	  for(int i=0 ; i <3 ; i++)
	  {
		text += $"Hello {name[i]} your score is {score[i] } \n";
	  }
      myLabel.Text = text;

	}*/

private void AudiRun(double distance)
{
	var timeuse = audi.TimeUseForRun(distance);
	ImageCar1.TranslateTo(distance-100,0,timeuse*1000,Easing.Linear); //*1000เพราะตอนแรกไม่คูณละวิ่งเร็วเกินไป
	
}

private void NissanRun(double distance)
{
	var timeuse = nissan.TimeUseForRun(distance);
	ImageCar2.TranslateTo(distance - 100,0,timeuse*1000,Easing.Linear);
}

} 

