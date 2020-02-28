using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private Color deathColor;

    public int Health { get => health; }

    private void OnMouseDown()
    {
        health -= 10;

        if (health <= 0)
        {
            health = 0;
            gameObject.GetComponent<Renderer>().material.color = deathColor;
        }
    }

}
