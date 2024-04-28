using UnityEngine;

[System.Serializable]
public class QuestionAndAnswer
{
    public string Question;
    public string[] Answer;
    public int CorrectAnswer;

}

// Opción #1
using System;
using System.Windows.Forms;

namespace EjemploBotonImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Crear un nuevo botón
            Button botonImagen = new Button();
            // Establecer la ubicación y el tamaño del botón
            botonImagen.Location = new System.Drawing.Point(100, 100);
            botonImagen.Size = new System.Drawing.Size(100, 50);
            // Establecer una imagen para el botón
            botonImagen.Image = Image.FromFile("Assets/miImagen.png"); // Ajusta la ruta según la ubicación de tu imagen
            // Ajustar el tamaño de la imagen al tamaño del botón
            botonImagen.BackgroundImageLayout = ImageLayout.Stretch;
            // Añadir el botón al formulario
            Controls.Add(botonImagen);
        }
    }
}
