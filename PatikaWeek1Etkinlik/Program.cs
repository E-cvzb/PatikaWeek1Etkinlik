using System.ComponentModel.Design;

Console.WriteLine("lütfen sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());

if (number>=10)
{
    if (number % 2 ==0)
    {
        Console.WriteLine("girilen sayı 10 dan büyüktür");
        Console.WriteLine("giren sayı çifttir");
    }
    else if (number==10)
    {
        Console.WriteLine("giren sayı 10 a eşittir");
        Console.WriteLine("giren sayı çifttir");
    }
    
    
    else
    {

        Console.WriteLine("giren sayı 10 dan büyüktür");
        Console.WriteLine("giren sayı tektir");
    }



}
else if (number<10 && number>0)
{
    if (number%2==0)
    {
        Console.WriteLine("giren sayı 10 dan küçüktür");
        Console.WriteLine("giren sayı çifttir");
    
    

    }
    else
    {
        Console.WriteLine("giren sayı 10 dan küçüktür");
        Console.WriteLine("giren sayı tektir");

    }

}
else if (number==0)
{
    Console.WriteLine("giren sayı 10 dan küçük ve 0 a eşittir");
    Console.WriteLine("giren sayı çifttir");
}

else
{
    if (number%2 ==0)
    {
        Console.WriteLine("giren sayı 10 dan küçük ve nagatiftir.");
        Console.WriteLine("giren sayı çiftit");
    }
    else
    {
        Console.WriteLine("girilen sayı 10 dan küçük ve negatifir.");
        Console.WriteLine("girilen sayı tektir");
    }
}