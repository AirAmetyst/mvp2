using Asteroids.Model;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ShipPresenter : Presenter
{
    private Root _init;
    
    
    
    
    public static int life = 3;
    
    public static int GetHealth()
    {
        
        return life;
    }
    public void  ReloadHealth()
    {

        life = 3;
    }

    public void Init(Root init)
    {
        _init = init;
    }

    public void Restart()
    {
         SceneManager.LoadScene(" ");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            life -= 1;
            if(life == 0)
            {
                
                _init.DisableShip();
                _init.OnShipDestroying();
                



            }
            
        }
    }
}
