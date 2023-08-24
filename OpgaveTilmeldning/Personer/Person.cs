
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpgaveTilmeldning.Code;

namespace OpgaveTilmeldning.Personer
{
    public enum CountryCode
    {
        DK,
        EN
    }

    // Abstract 
    //klasse er base klasse for teacher og studen
    internal abstract class Person
    {
        public PersonModel? PersonInfo { get; set; }
        public DateTime Fødselsdag { get; set; }
        public int Alder { get; set; }
        public string Type { get; set; }


        public Person(string? fornavn, string? efternavn, DateTime fødselsdag, string? type)
        {
            PersonInfo = new() { Fornavn = fornavn, Efternavn = efternavn };
            Fødselsdag = fødselsdag;
            Alder = new AgeConverter(fødselsdag).Age;
            Type = type;
        }

        protected string ShowFullName()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

        protected abstract string ShowAllInfo();



        protected virtual string ShowAllInfo2()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

        public virtual void SayHello() 
        {
            Console.WriteLine($"Hej, jeg er en {Type}");
        }

        public string SayHello(string type, string navn)
        {
            return $"Hej, jeg er en {type} og jeg hedder {navn}.";
        }
        public abstract string ShowMyIdentity();
    }
}