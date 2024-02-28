using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxScrolling : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RawImage backgroundImage;

    public float parallaxSpeed = 0.5f; // Ajuste esta velocidade para controlar o quão rápido a imagem de fundo se move em relação ao scroll

    private float initialScrollPosY;
    private float initialBackgroundPosY;

    void Start()
    {
        initialScrollPosY = scrollRect.normalizedPosition.y;
        initialBackgroundPosY = backgroundImage.uvRect.y;
    }

    void Update()
    {
        // Obtém a posição normalizada atual do ScrollRect no eixo Y
        float currentScrollPosY = scrollRect.normalizedPosition.y;

        // Calcula o deslocamento da imagem de fundo com base na diferença entre a posição atual e inicial do ScrollRect
        float scrollOffset = (initialScrollPosY - currentScrollPosY) * parallaxSpeed;

        // Aplica o deslocamento à posição Y da imagem de fundo
        Rect uvRect = backgroundImage.uvRect;
        uvRect.y = initialBackgroundPosY + scrollOffset;
        backgroundImage.uvRect = uvRect;
    }
}
