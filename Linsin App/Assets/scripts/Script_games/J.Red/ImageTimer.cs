using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ImageTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float countdown = 10f;
    public RawImage image;

    void Start()
    {
        image.enabled = true;

        // Procura o objeto com o nome "TimerText" na cena
        GameObject timerTextObj = GameObject.Find("TimerText");

        // Verifica se o objeto foi encontrado
        if (timerTextObj != null)
        {
            // Obtém o componente TextMeshProUGUI do objeto encontrado
            timerText = timerTextObj.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            // Exibe mensagem de erro no console
            Debug.LogError("Objeto TimerText não encontrado!");
        }
    }

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            image.enabled = false;
        }

        float timeLeft = Mathf.CeilToInt(countdown);
        timerText.text = "Tempo Restante: " + timeLeft.ToString();
    }
}
