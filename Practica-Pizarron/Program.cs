﻿using System;
using System.Collections.Generic;

namespace Practica_Pizarron
{
    class Auto
    {
        private string marca;
        private string color;
        private int ano;
        private string modelo;

        public void setMarca(string marca)
        {
            this.marca= marca;
        } 

        public string getMarca()
        {
            return this.marca;
        } 

        public void setColor(string color)
        {
            this.color= color;
        } 

        public string getColor()
        {
            return this.color;
        } 
        
        public void setAno(int ano)
        {
            this.ano= ano;
        } 

        public int getAno()
        {
            return this.ano;
        } 
        
        public void setModelo(string modelo)
        {
            this.modelo= modelo;
        } 

        public string getModelo()
        {
            return this.modelo;
        } 

        public Auto( string marca, string color, int ano, string modelo)
        {
            this.marca=marca;
            this.color=color;
            this.ano=ano;
            this.modelo=modelo;
        }

        public Auto()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto= new Auto("Toyota","Negro",2019,"Corolla");
            Auto autob= new Auto("Jetta","Gris",2009,"Wolkswagen");
            Console.WriteLine("{0},{1},{2},{3}",auto.getMarca,auto.getColor,auto.getAno);
            
            
            


        }
    }
}
