int PinAnalogo = 0; // Definimos la entrada en pin A0

void setup()
{
  pinMode(13, OUTPUT);
  Serial.begin(115200);
  Inicializar_Serial();
}

void loop()
{
  Definir_Accion();
}

int Definir_Accion()
{
  if(Serial.available())
  {
      switch(Serial.read())
      {
         case 'r'://Leer entrada analogica y mandar dato
           Leer_Entrada();
         break;
         case 't':  //Prender Led Prueba
           Prender_Led();
         break;
         case 'k':  //Apagar Led Prueba
           Apagar_Led();
         break; 
         case 's': //En espera a nueva inicializacion
           Salir();
         break;
      }
  }
}

void Salir()
{
  Inicializar_Serial(); //Loop espera la inicializacion
}

void Leer_Entrada()
{
    int dato = 0;
    dato = 10*analogRead(PinAnalogo); //lectura del pin analogico 0
    dato = (5.0 * dato)/1024.0;
    Serial.write(dato);
}

void Prender_Led()
{
    digitalWrite(13, HIGH);   //Prende el led 13
    Serial.write('t');
}

void Apagar_Led()
{
    digitalWrite(13, LOW);   //Prende el led 13
    Serial.write('k');
}



//Se inicializa conexion serial
//Debe mandar una secuencia de caracteres tal que cumplan con el criterio "probar"
void Inicializar_Serial()
{
  int caracter[6];
  int i = 0;
  caracter[0] = 'p';
  caracter[1] = 'r';
  caracter[2] = 'o';
  caracter[3] = 'b';
  caracter[4] = 'a';
  caracter[5] = 'r';
  
  while(1)     //Mientras no se inicialize no sale del ciclo
  {
     if(Serial.available())
     {
        if(Serial.read() == caracter[i])
        {
          if(i == 5)
          {
            Serial.write('a');  //mandamos por serial el caracter de confirmacion a
            break;
          }
          i++;
        }
      } 
  }
}
