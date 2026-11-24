using System;

public class Kosc
{
	public static int liczbaInstancji = 0;

	public static string[] nazwyPlikow =
	[
		"kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png",
		"kosc4.png", "kosc5.png", "kosc6.png"
	];

	public int liczbaOczek;
	public int identyfikatorPliku;
	public bool dostepna;

	public Kosc(int wartosc)
	{
		liczbaOczek = (wartosc >= 1 && wartosc <= 6) ? wartosc : 0;
		identyfikatorPliku = liczbaOczek;
		dostepna = true;
		liczbaInstancji++;
	}

	public Kosc() : this(Random.Shared.Next(1, 7))
	{
	}

	public void Rzut()
	{
		if (!dostepna) return;

		liczbaOczek = Random.Shared.Next(1, 7);
		identyfikatorPliku = liczbaOczek;
	}

	public void Zablokuj() => dostepna = false;

	public string PodajWynikSlownie() => liczbaOczek switch
	{
		1 => "jeden",
		2 => "dwa",
		3 => "trzy",
		4 => "cztery",
		5 => "pięć",
		6 => "sześć",
		_ => "zero"
	};
}
