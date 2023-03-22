using System;

public class Samochod
{
	public Samochod() { }
	private int _id;
	private string _marka = "";
	private string _model = "";
	private float _pojemnosc;
	private float _przyspieszenie;
	private float _spalanie;

	public int Id
	{
		get => _id;
		set => _id = value;
	}

	public string Marka
	{
		get => _marka;
		set => _marka = value;
	}

	public string Model
	{
		get => _model;
		set => _model = value;
	}

	public float Pojemnosc
	{
		get => _pojemnosc;
		set => _pojemnosc = value;
	}

	public float Przyspieszenie
	{
		get => _przyspieszenie;
		set => _przyspieszenie = value;
	}

	public float Spalanie
	{
		get => _spalanie;
		set => _spalanie = value;
	}
}
