using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoracaoSystem : MonoBehaviour
{

    public int vida;
    public int vidaMaxima;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
        Dead();
    }

    void HealthLogic() 
    {

        if (vida > vidaMaxima) 
        {
            vida = vidaMaxima;
        }
        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < vida)
            {
                coracao[i].sprite = cheio;
            }
            else
            {
                coracao[i].sprite = vazio;
            }

            if (i < vidaMaxima)
            {
                coracao[i].enabled = true;
            }
            else 
            {
                coracao[i].enabled = false;
            }
        
        }

    }

    void Dead() 
    {
        if(vida <= 0) 
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
