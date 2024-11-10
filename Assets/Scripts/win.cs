using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text pointsText;     // Referencia al TextMeshPro que muestra los puntos.
    public TMP_Text winText;        // Texto adicional que mostrará un mensaje de victoria.
    
    private int points = 0;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        // Asegúrate de que el texto de victoria esté vacío al inicio
        if (winText != null)
        {
            winText.text = "";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que tocó es el jugador.
        if (other.CompareTag("Player"))
        {
            // Aumenta los puntos.
            points++;

            // Actualiza el texto de puntos en pantalla.
            pointsText.text = "Points: " + points;

            // Verifica si esta moneda tiene la etiqueta "Win"
            if (gameObject.CompareTag("Win"))
            {
                // Mostrar mensaje de victoria
                if (winText != null)
                {
                    winText.text = "Congrats!! You Win the game!!!!";
                }

             
            }

            // Destruye la moneda.
            Destroy(gameObject);

            if (other.CompareTag("GameOver"))
            {
                // Reaparece al jugador en la posición inicial
                transform.position = startPosition;
            }
        }
       


    }
}