using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text textoUI1;
    public Text textoUI2;
    public Text textoUI3;
    public Text textoUI4;

    public LanguageText textoCastellano;
    public LanguageText textoCatalan;
    public LanguageText textoIngles;

    private LanguageText currentLanguageText;

    void Start()
    {
        SetLanguage(textoCastellano);  // Establecer idioma por defecto
    }

    // Cambiar idioma y actualizar UI
    public void SetLanguage(LanguageText newLanguageText)
    {
        currentLanguageText = newLanguageText;

        textoUI1.text = currentLanguageText.texto1;
        textoUI2.text = currentLanguageText.texto2;
        textoUI3.text = currentLanguageText.texto3;
        textoUI4.text = currentLanguageText.texto4;
    }

    // Funciones para seleccionar idioma
    public void SetCastellano()
    {
        SetLanguage(textoCastellano);
    }

    public void SetCatalan()
    {
        SetLanguage(textoCatalan);
    }

    public void SetIngles()
    {
        SetLanguage(textoIngles);
    }
}
