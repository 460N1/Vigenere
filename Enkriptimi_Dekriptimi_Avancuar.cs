using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VingereEncDec
{
    class Enkriptimi_Dekriptimi_Avancuar
    {
            public string k = "";
            private string Plainteksti, Celesi, CelesiAlfabetik;
            public Enkriptimi_Dekriptimi_Avancuar(string P, string C, string CA)
            {
                this.Plainteksti = P.ToUpper();
                this.Celesi = C.ToUpper();
                this.CelesiAlfabetik = CA.ToUpper();
            }
            public string Fshij_Duplikatet()
            {
                string Alfabeti = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string Hyrja;
                Hyrja = CelesiAlfabetik + Alfabeti;
                string rez = new String(Hyrja.ToCharArray().Distinct().ToArray());
                return rez;
            }
            public int Gjej_Vlerat_Shkronjave(char a)
            {
                string AlfabetiPerfundimtar = Fshij_Duplikatet();
                int VleraKarakterit = 0;
                if (char.IsLetter(a) == true)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < AlfabetiPerfundimtar.Length; j++)
                        {
                            if (a.ToString() == AlfabetiPerfundimtar[j].ToString())
                            {
                            VleraKarakterit = VleraKarakterit + AlfabetiPerfundimtar.IndexOf(AlfabetiPerfundimtar[j]);
                            }
                        }
                    }
                }
                else { VleraKarakterit = -1; }
                return VleraKarakterit;
            }         
            public string Enkript()
            {
                string AlfabetiPerfundimtar = Fshij_Duplikatet();
                int ShkronjaEnkriptuar;
                int j = 0;
                    for (int i = 0; i < Plainteksti.Length; i++)
                    {
                    Labela1: if (j < Celesi.Length)
                    {
                        if (Gjej_Vlerat_Shkronjave(Celesi[j]) != -1)
                        {
                        if (Gjej_Vlerat_Shkronjave(Plainteksti[i]) != -1)
                        {
                            ShkronjaEnkriptuar = (Gjej_Vlerat_Shkronjave(Plainteksti[i]) + Gjej_Vlerat_Shkronjave(Celesi[j])) % 26;
                            k = k + AlfabetiPerfundimtar[ShkronjaEnkriptuar];
                            j++;
                        }
                        else { k = k + " "; }
                    }
                    else { j++; goto Labela1; }
                    }
                    else
                    { j = 0; goto Labela1; }
                    }
                return k;
            }
            public string Dekript()
            {
                string AlfabetiPerfundimtar = Fshij_Duplikatet();
                int ShkronjaEnkriptuar;
                int j = 0;
                for (int i = 0; i < Plainteksti.Length; i++)
                {
                        Labela1: if (j < Celesi.Length)
                        {
                        if (Gjej_Vlerat_Shkronjave(Celesi[j]) != -1)
                        {
                        if (Gjej_Vlerat_Shkronjave(Plainteksti[i]) != -1)
                        {
                            ShkronjaEnkriptuar = (Gjej_Vlerat_Shkronjave(Plainteksti[i]) - Gjej_Vlerat_Shkronjave(Celesi[j])) % 26;
                        if ((Gjej_Vlerat_Shkronjave(Plainteksti[i]) - Gjej_Vlerat_Shkronjave(Celesi[j])) < 0)
                        {     
                            k = k + AlfabetiPerfundimtar[ShkronjaEnkriptuar+26];
                        }
                        else
                        {   
                            k = k + AlfabetiPerfundimtar[ShkronjaEnkriptuar];
                        }
                            j++;
                        }
                        else { k = k + " "; }
                        }
                        else { j++; goto Labela1; }
                        }
                        else
                        { j = 0; goto Labela1; }
                }
                return k;
            }  
    }
}
