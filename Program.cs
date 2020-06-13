using System;

public class Program
{
    public static void Main(string[] args)
    {
		//abstract class
		Console.WriteLine("ABSTRACT CLASS");
        Kuliah kuliah;
        
        kuliah = new Dosen();
        kuliah.materi();
		kuliah.tugas();
		
		Console.WriteLine();
		kuliah = new Mahasiswa();
		kuliah.materi();
		kuliah.tugas();
		
		Console.WriteLine();
		Console.WriteLine();
		
		//interface
		Console.WriteLine("INTERFACE");
		IKomputer komputer;
		
		komputer = new monitor();
		komputer.info();
		komputer.fungsi();
		
		Console.WriteLine();
		komputer = new pc();
		komputer.info();
		komputer.fungsi();
		
		Console.WriteLine();
		komputer = new keyboard();
		komputer.info();
		komputer.fungsi();
    }
}

//abstract class
public abstract class Kuliah
    {
        public abstract void materi();
        public abstract void tugas();
    }

public class Dosen : Kuliah
{
    public override void materi()
    {
        Console.WriteLine("Dosen menjelaskan materi");
    }

    public override void tugas()
    {
        Console.WriteLine("Dosen memberikan tugas");
    }
}

public class Mahasiswa : Kuliah
{
    public override void materi()
    {
        Console.WriteLine("Mahasiswa mendengarkan materi");
    }

    public override void tugas()
    {
        Console.WriteLine("Mahasiswa mengerjakan tugas");
    }
}

//interface
public interface IKomputer
{
	void info();
	void fungsi();
}

public class monitor : IKomputer
{
	public void info()
	{
		Console.WriteLine("fungsi monitor : ");
	}
	
	public void fungsi()
	{
		Console.WriteLine("memberikan output tampilan grafis");
	}
}

public class pc : IKomputer
{
	public void info()
	{
		Console.WriteLine("fungsi pc : ");
	}
	
	public void fungsi()
	{
		Console.WriteLine("tempat untuk meletakkan perangkat-perangkat keras seperti motherboard, PSU, dll");
	}
}

public class keyboard : IKomputer
{
	public void info()
	{
		Console.WriteLine("fungsi keyboard : ");
	}
	
	public void fungsi()
	{
		Console.WriteLine("sebagai alat input perintah berupa teks");
	}
}