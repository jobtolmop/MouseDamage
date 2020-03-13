using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraListener : MonoBehaviour
{
    private CameraShake cameraShake;
    private Player player;

    private void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.OnDamage += CamShake;
    }

    private void CamShake(float a, float b)
    {
        StartCoroutine(cameraShake.Shake(a, b));
    }
}
