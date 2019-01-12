using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VingereEncDec
{
            enum Alfabeti  {A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z}
            class Enkriptimi_Dekriptimi_Bazik
            {
                public string k = "";
                private string PlainTexti, Celesi;
                public Enkriptimi_Dekriptimi_Bazik(string P, string C)
                {
                    this.PlainTexti = P.ToUpper();
                    this.Celesi = C.ToUpper();       
                }
                public int Gjej_Vlerat_Shkronjave(char a)
                {
                    int VleraKarakterit = 0;
                    if (char.IsLetter(a)==true)
                    {
                    string b = a.ToString();
                    for (int i = 0; i < b.Length; i++)
                    {
                        for (int j = 0; j < 26; j++)
                        {
                        Alfabeti Shkronja = (Alfabeti)j;
                        if (b == Shkronja.ToString())
                        {
                        VleraKarakterit = VleraKarakterit + (int)Shkronja;
                        }
                    }
                    }
                    }
                    else { VleraKarakterit = -1; }
                    return VleraKarakterit;         
                }
                public string Enkript()
                {
                    double ShkronjaEnkriptuar;
                    int j = 0;
                    for (int i = 0; i < PlainTexti.Length; i++)
                    {
                        Labela1: if (j < Celesi.Length)
                        {
                        if (Gjej_Vlerat_Shkronjave(Celesi[j]) != -1)
                        {
                        if (Gjej_Vlerat_Shkronjave(PlainTexti[i]) != -1)
                        {
                            ShkronjaEnkriptuar = (Gjej_Vlerat_Shkronjave(PlainTexti[i]) + Gjej_Vlerat_Shkronjave(Celesi[j])) % 26;
                            Alfabeti Shkronja = (Alfabeti)ShkronjaEnkriptuar;
                            k = k + Shkronja;
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
                    string k = "";
                    double ShkronjaEnkriptuar;
                    int j = 0;
                    for (int i = 0; i < PlainTexti.Length; i++)
                    {
                    Labela1: if (j < Celesi.Length)
                    {
                    if (Gjej_Vlerat_Shkronjave(Celesi[j]) != -1)
                    {
                    if (Gjej_Vlerat_Shkronjave(PlainTexti[i]) != -1)
                    {
                        ShkronjaEnkriptuar = (Gjej_Vlerat_Shkronjave(PlainTexti[i]) - Gjej_Vlerat_Shkronjave(Celesi[j])) % 26;
                        if ((Gjej_Vlerat_Shkronjave(PlainTexti[i]) - Gjej_Vlerat_Shkronjave(Celesi[j])) < 0)
                        {
                        Alfabeti Shkronja = (Alfabeti)ShkronjaEnkriptuar + 26;
                        k = k + Shkronja;
                        }
                        else
                        {
                            Alfabeti Shkronja = (Alfabeti)ShkronjaEnkriptuar;
                            k = k + Shkronja;
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
