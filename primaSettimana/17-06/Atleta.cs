﻿public class Atleta
{
    public string nome;
    public string cognome;
    public int eta;
    public string sport;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }

    }
    public string Cognome
    {
        get { return cognome; }
        set { cognome = value; }
    }
    public int Eta
    {
        get { return eta; }
        set { eta = value; }
    }
    public string Sport
    {
        get { return sport; }
        set { sport = value; }
    }
    public void Descriviti()
    {
        Console.WriteLine($"Mi chiamo {nome} {cognome}, ho {eta} anni e pratico { sport} ");
    }
}