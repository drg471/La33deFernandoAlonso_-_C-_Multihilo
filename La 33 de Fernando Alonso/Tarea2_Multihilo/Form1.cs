using System.Media;
using Tarea2_Multihilo.Properties;

namespace Tarea2_Multihilo
{
    public partial class Form1 : Form
    {
        //Declaracion de delegados e hilos
        delegate void delegadoCOM();
        delegate void delegadoJ1();
        Thread caballoCOM;
        Thread caballoJ1;

        //Declaracion de variables
        int _intTiempoDificultad = 0;
        int _intTiempoInicialAceleracionJ1 = 52;
        int _intTiempoAceleracionJ1 = 0;
        int _intContadorClicksAceleracion = 10;
        int _intContadorBarraProgeso = 100;
        bool _blnHayGanador = false;
        bool _blnAcabarPartida = false;
        bool _blnJ1Cansado = false;

        SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            //Centra la ventana en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //Configura el valor inicial de la ProgressBar al maximo
            MostrarProgreso(pbAceleracion.Maximum);

            //Suscribe el método al evento FormClosing
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        //Metodo que se ejecuta al pulsar el boton de Iniciar
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Inicializa propiedades de elementos del formulario
            btnAcelerar.Visible = true;
            btnAcelerar.Enabled = true;
            txtAceleracion.Visible = true;
            btnIniciar.Enabled = false;
            rbNivelFacil.Enabled = false;
            rbNivelDificil.Enabled = false;
            rbNivelExperto.Enabled = false;

            //Llamada al metodo de seleccion de nivel
            SeleccionNivelDificultad();

            //Inicializa el tiempo con el que el usuario empieza a jugar
            _intTiempoAceleracionJ1 = _intTiempoInicialAceleracionJ1;

            //crea los hilos para los movimientos de los coches rivales y el del coche del jugador pasandoles su delegado
            caballoCOM = new Thread(metodoDelegadoCOM);
            caballoJ1 = new Thread(metodoDelegadoJ1);
            //Inicia los hilos de movimiento
            caballoCOM.Start();
            caballoJ1.Start();

            txtAceleracion.Text = Convert.ToString(_intContadorClicksAceleracion);
        }

        //Metodo que utiliza un delegado para invocar el metodo 'movimientoCOM'
        private void metodoDelegadoCOM()
        {
            //Crea una instancia del delegado 'movimientoDelegadoCOM' y la inicializa con el metodo 'movimientoCOM'
            delegadoCOM movimientoDelegadoCOM = new delegadoCOM(movimientoCOM);
            movimientoDelegadoCOM.Invoke();  //Invoca el metodo 'movimientoCOM' a traves del delegado
        }

        private void metodoDelegadoJ1()
        {
            delegadoJ1 movimientoDelegadoJ1 = new delegadoJ1(movimientoJ1);
            movimientoDelegadoJ1.Invoke();
        }

        //Metodo que simula el movimiento de los coches
        private void movimientoCOM()
        {
            //Crea una instancia de la clase Random para generar numeros aleatorios
            Random aleatorio = new Random();

            //Ejecuta un bucle para simular el avance de los coches
            for (int i = 0; i < this.Width - caballo1.Width - 50; i++)
            {
                //Comprueba si se ha indicado que la partida debe finalizar
                if (_blnAcabarPartida)
                {
                    //Sale del bucle
                    break;
                }

                //Mueve cada coche a la derecha aleatoriamente
                caballo2.Left += aleatorio.Next(10);
                caballo3.Left += aleatorio.Next(10);
                caballo4.Left += aleatorio.Next(10);

                //Detiene la ejecucion del hilo actual para simular el tiempo entre movimientos
                Thread.Sleep(_intTiempoDificultad);

                //Comprueba si hay un ganador en la carrera
                if (ComprobarGanador())
                {
                    //Si hay un ganador deshabilita el boton de acelerar y sale del bucle
                    btnAcelerar.Enabled = false;
                    break;
                }
            }

            //Habilita el boton de reiniciar despues de que la carrera haya finalizado
            btnReiniciar.Enabled = true;
        }


        private void movimientoJ1()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < this.Width - caballo1.Width - 50; i++)
            {
                if (_blnAcabarPartida)
                {
                    break;
                }

                try
                {
                    caballo1.Left += aleatorio.Next(10);
                }
                catch (Exception ex)
                {
                    caballo1.Left += 3;

                }


                Thread.Sleep(_intTiempoAceleracionJ1);

                if (ComprobarGanador())
                {
                    btnAcelerar.Enabled = false;
                    break;
                }
            }

            btnReiniciar.Enabled = true;
        }

        //Metodo que se ejecuta al pulsar el boton de Reiniciar
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Reinicia valores de elementos y variables para poder reiniciar el juego
            caballo1.Left = 50;
            caballo2.Left = 50;
            caballo3.Left = 50;
            caballo4.Left = 50;
            pbPodio1.Visible = false;
            pbPodio2.Visible = false;
            pbPodio3.Visible = false;
            btnIniciar.Enabled = true;
            btnReiniciar.Enabled = false;
            _blnHayGanador = false;
            _intTiempoAceleracionJ1 = _intTiempoInicialAceleracionJ1;
            _intContadorClicksAceleracion = 10;
            txtAceleracion.Text = Convert.ToString(10);
            txtAceleracion.BackColor = Color.White;
            btnAcelerar.Enabled = false;
            rbNivelFacil.Enabled = true;
            rbNivelDificil.Enabled = true;
            rbNivelExperto.Enabled = true;
            pbConfeti.Visible = false;
            _intContadorBarraProgeso = 100;
            MostrarProgreso(_intContadorBarraProgeso);
            player.Play();
        }

        //Metodo que se ejecuta al pulsar el boton de Atrás
        private void btnAtras_Click(object sender, EventArgs e)
        {
            _blnAcabarPartida = true;
            player.Stop(); //Para la musica
            Application.Exit();  // Cierra la aplicación
        }

        //Metodo que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializa valores de variables y elementos necesarios para iniciar el juego
            pbPodio1.Visible = false;
            pbPodio2.Visible = false;
            pbPodio3.Visible = false;
            btnReiniciar.Enabled = false;
            rbNivelFacil.Checked = true;
            btnAcelerar.Enabled = false;
            pbConfeti.Visible = false;
            //Crea una instancia de la clase SoundPlayer para reproducir un archivo de sonido
            player = new SoundPlayer(Resources.racesong);
            //Inicia la reproduccion del sonido
            player.Play();

        }

        //Metodo que comprueba si hay un ganador comparando las posiciones actuales de los coches con el limite de la pista.
        private bool ComprobarGanador()
        {
            //comprueba si ya hay un ganador
            if (!_blnHayGanador)
            {
                //Si el primer coche ha alcanzado la linea de meta se declara ganador y se muestra un mensaje
                if (caballo1.Left >= this.Width - caballo1.Width - 50)
                {
                    _blnHayGanador = true;
                    MessageBox.Show("Has ganado Fernando Alonso! LA 33!!!!");

                    //Llama al metodo ComprobarPodio para determinar y mostrar el podio
                    ComprobarPodio(caballo1, caballo2, caballo3, caballo4);

                    return true; //Indica que hay un ganador
                }
                else if (caballo2.Left >= this.Width - caballo2.Width - 50)
                {
                    _blnHayGanador = true;
                    MessageBox.Show("Ganador Lando Norris");
                    ComprobarPodio(caballo2, caballo1, caballo3, caballo4);
                    return true;
                }
                else if (caballo3.Left >= this.Width - caballo3.Width - 50)
                {
                    _blnHayGanador = true;
                    MessageBox.Show("Ganador Max Verstappen");
                    ComprobarPodio(caballo3, caballo1, caballo3, caballo4);
                    return true;
                }
                else if (caballo4.Left >= this.Width - caballo4.Width - 50)
                {
                    _blnHayGanador = true;
                    MessageBox.Show("Ganador Carlos Sainz");
                    ComprobarPodio(caballo4, caballo1, caballo2, caballo3);
                    return true;
                }
                return false;
            }
            return true;
        }

        //Metodo que determina y muestra el podio de la carrera colocando los coches ganadores en las posiciones correspondientes.

        private void ComprobarPodio(PictureBox pbGanador, PictureBox pb2, PictureBox pb3, PictureBox pb4)
        {
            //Muestra el primer lugar del podio con la imagen del coche ganador
            pbPodio1.Visible = true;
            pbPodio1.BackgroundImage = getImagePodium(pbGanador);

            //Muestra los lugares restantes del podio
            pbPodio2.Visible = true;
            pbPodio3.Visible = true;

            //Comprobar si pb2 es mas que pb3 y pb4
            if ((pb2.Left > pb3.Left) && (pb2.Left > pb4.Left))
            {
                pbPodio2.BackgroundImage = getImagePodium(pb2); //Pone de segundo a pb2

                //Comprobar si pb3 es mas que pb4
                if (pb3.Left > pb4.Left)
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb3); //Pone de tercero a pb3
                }
                else
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb4); //Pone de tercero a pb4
                }
            }
            //Comprobar si pb3 es mas que pb2 y pb4
            else if ((pb3.Left > pb2.Left) && (pb3.Left > pb4.Left))
            {
                pbPodio2.BackgroundImage = getImagePodium(pb3); ;

                if (pb2.Left > pb4.Left)
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb2);
                }
                else
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb4);
                }
            }
            //Comprobar si pb4 es mas que pb2 y pb3
            else if ((pb4.Left > pb2.Left) && (pb4.Left > pb3.Left))
            {
                pbPodio2.BackgroundImage = getImagePodium(pb4);

                if (pb2.Left > pb3.Left)
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb2);
                }
                else
                {
                    pbPodio3.BackgroundImage = getImagePodium(pb3);
                }
            }
            pbConfeti.Visible = true; //Muestra la imagen de confeti para celebrar la victoria
        }

        //Metodo que devuelve la imagen del podio correspondiente al piloto 
        private Image getImagePodium(PictureBox pictureBox)
        {
            //Selector switch para determinar la imagen del podio segun el nombre del PictureBox
            switch (pictureBox.Name)
            {
                //Si el PictureBox es "caballo1" devuelve la imagen del podio asociada al piloto caballo1
                case "caballo1":
                    return Resources.aloPodium;
                case "caballo2":
                    return Resources.norPodium;
                case "caballo3":
                    return Resources.verPodium;
                case "caballo4":
                    return Resources.saiPodium;
                default:
                    return Resources.aloPodium;
            }
        }

        //Metodo que ajusta la dificultad del juego segun la opcion de nivel seleccionada por el usuario
        private void SeleccionNivelDificultad()
        {
            //Si la opcion de nivel facil esta seleccionada establece un tiempo de dificultad
            if (rbNivelFacil.Checked)
            {
                _intTiempoDificultad = 38;
            }
            else if (rbNivelDificil.Checked)
            {
                _intTiempoDificultad = 34;
            }
            else if (rbNivelExperto.Checked)
            {
                _intTiempoDificultad = 31;
            }
        }

        //Metodo que maneja el evento de click en el boton de acelerar
        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            //Comprueba si el jugador 1 no esta cansado
            if (!_blnJ1Cansado)
            {
                //Comprueba si se han realizado mas de un click de aceleracion
                if (_intContadorClicksAceleracion > 1)
                {
                    //Reduce el tiempo de aceleracion, decrementa el contador de clicks y actualiza la barra de progreso y el cuadro de texto
                    _intTiempoAceleracionJ1 -= 2;
                    _intContadorClicksAceleracion--;
                    _intContadorBarraProgeso -= 10;
                    MostrarProgreso(_intContadorBarraProgeso);
                    txtAceleracion.Text = Convert.ToString(_intContadorClicksAceleracion);
                }
                else
                {
                    //Si se ha alcanzado el limite de clicks el jugador 1 se cansa
                    _blnJ1Cansado = true;
                    _intTiempoAceleracionJ1 = 100;
                    txtAceleracion.BackColor = Color.Red;
                    MostrarProgreso(1);
                    pbAceleracion.BackColor = Color.Red;

                    //Reinicia el contador de clicks y actualiza el cuadro de texto
                    _intContadorClicksAceleracion = 0;
                    txtAceleracion.Text = Convert.ToString(_intContadorClicksAceleracion);
                }
            }
            else
            {
                //Si el jugador 1 esta cansado reincia sus atributos a los valores iniciales
                _blnJ1Cansado = false;
                _intTiempoAceleracionJ1 = _intTiempoInicialAceleracionJ1;
                _intContadorClicksAceleracion = 10;
                txtAceleracion.Text = Convert.ToString(10);
                txtAceleracion.BackColor = Color.White;
                _intContadorBarraProgeso = 100;
                MostrarProgreso(_intContadorBarraProgeso);
            }
        }

        //Metodo que actualiza el valor de la barra de progreso de la aceleracion
        private void MostrarProgreso(int actual)
        {
            //Asigna el valor actual a la barra de progreso de aceleracion
            pbAceleracion.Value = actual;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            Application.Exit();  //Cierra la aplicacion cuando se cierra la ventana
        }

    }
}
