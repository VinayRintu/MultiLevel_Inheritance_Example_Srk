// See https://aka.ms/new-console-template for more information
using MultiLevel_Inheritance_Example_Srk;

Console.WriteLine("Hello, World!");

Son objSon = new Son();

objSon.grandFatherName = "Shaik Dawood";
objSon.amountOfGrandFather = 100000;
Console.WriteLine("Grand Fathers Name  : " + objSon.grandFatherName);
Console.WriteLine("Total Amount Of GrandFather  : " + objSon.amountOfGrandFather);

objSon.fatherName = "Shravan Kumar";
Console.WriteLine("Name Of The Father  : " + objSon.fatherName);
Console.WriteLine("Amount Of Father  : " + objSon.CalculateFatherAmount());

objSon.sonName = "Vinay Rintu";
Console.WriteLine("Son's Name  : " + objSon.sonName);
Console.WriteLine("Total Amount Of Son  : " + objSon.CalculateSonAmount());

