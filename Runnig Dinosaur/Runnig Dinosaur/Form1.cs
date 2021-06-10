using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Runnig_Dinosaur
{
    //Miguel Daniel Reyes Martinez
    //
    //ESPACIO PARA SALTAR - "R" PARA REINICIAR
    //
    public partial class Form1 : Form //variables a usarse
    {
        bool salto = false; //salto
        int velocidadSalto; //la velocidad del salto
        int fuerza = 12; //la fuerza del salto
        int score = 0;  //el puntaje
        int velocidadObstaculo = 10; //velocidad de movimiento de los obstaculos
        Random rand = new Random(); //un metodo random que servira para posicionar los obstaculos
        int posicion; //la posicion del dinosaurio en pantalla
        bool gameOver = false; //un game over
        SoundPlayer jump = new SoundPlayer("jump.wav");
        SoundPlayer losing = new SoundPlayer("losing.wav"); //todas estan guardadas en debug/netcoreApp3.1
        SoundPlayer rdy = new SoundPlayer("ready.wav");
        SoundPlayer point = new SoundPlayer("point.wav");
        SoundPlayer serious = new SoundPlayer("serious.wav");
        //SoundPlayer bckground = new SoundPlayer("corona.wav");
        public Form1()
        {
            InitializeComponent(); //jamas nunca borrar!

            resetJuego(); //se declara la clase aqui para que se inicie con los valores iniciales 
            rdy.Play();
            //bckground.PlayLooping();
           
        }

        private void contadorJuegoPrincipal(object sender, EventArgs e)  //contador principal, donde esta la mayoria de la logica
        {
            tRex.Top += velocidadSalto;     
            puntaje.Text = "Puntaje: " + score; //el indicador del puntaje obtenido

            if (salto == true && fuerza < 0) 
            {
                salto = false;
            }
            if (salto == true)
            {
                velocidadSalto = -12;
                fuerza -= 1;
            }
            else
            {
                velocidadSalto = 12;
            }

            if (tRex.Top > 353 && salto == false)
            {
                fuerza = 12;
                tRex.Top = 354;
                velocidadSalto = 0;
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstaculo") //se controla la velocidad de los obstaculos, 
                {
                    x.Left -= velocidadObstaculo;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15); //en pixeles va ubicando los obstaculos
                        score++;
                        point.Play();

                    }

                    if (tRex.Bounds.IntersectsWith(x.Bounds)) //la colision o la hitbox, si toca el obstaculo se muere y gameover
                    {
                        contadorTiempo.Stop();   //se para el timer
                        tRex.Image = Properties.Resources.dead;  //cambia a la imagen de muerto
                        puntaje.Text = " Presiona R para volver a comenzar! "; //texto de aviso
                        gameOver = true; //termina el juego
                        losing.Play();
                    }
                }
                              
            }

            if (score >= 10) //al llegar a 10 el puntaje se aumenta la velocidad de los obstaculos
            {
                
                velocidadObstaculo = 15;

            }

            if (score >= 20)
            {
                velocidadObstaculo = 20;
            }

            if (score >= 30)
            {
                velocidadObstaculo = 25;
            }

        }

        private void keyIsDown(object sender, KeyEventArgs e) //evento si la key esta abajo
        {
            if (e.KeyCode == Keys.Space && salto == false)  //cambiamos abajo por espacio
            {
                salto = true;   //salta el dino
                jump.Play();
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e) //evnto si la key esta arriba
        {
          if (salto==true)
            {
                salto = false;
            }

          if (e.KeyCode==Keys.R && gameOver==true)  //si se pierde el juego se reinicia con la letra R
            {
                resetJuego(); //hace un llamado a la clase de reset
            }
        }

        private void resetJuego() //valores iniciales con los que se comenzara el juego
        {
            rdy.Play();
            fuerza = 12;
            velocidadSalto = 0;
            salto = false;
            score = 0;
            velocidadObstaculo = 10;
            puntaje.Text = "Puntaje: " + score;          //el puntaje 
            tRex.Image = Properties.Resources.running; //la imagen del dino corriendo
            gameOver = false;
            tRex.Top = 354;  //posicion en donde comenzara el dinosaurio
            

            foreach (Control x in this.Controls) //un foreach para controlar los obstaculos al mismo tiempo
            {
                if (x is PictureBox && (string)x.Tag == "obstaculo") //se tagean ambas picturebox con el nombre de tag, para que sea mas facil
                {
                    posicion = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10); //de forma random se asigna la posicion de los obstaculos al comienzo de cada partida
                    x.Left = posicion;
                }
            }

            contadorTiempo.Start(); //se inicia el timer

        }
    }
}
