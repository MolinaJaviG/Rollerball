using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class Coin : MonoBehaviour
{
    public static int count = 0;
    public static int maxCount = 0;
//    AudioSource SonidoMoneda;

    void Awake()
    {
        count++;
        maxCount++;
    }
    void Destroy()
    {
        

    }
    void OnTriggerEnter(Collider other) 
    {
        count--;
        Destroy(gameObject);
    }
//
//    private void Start()
//    {
//        transform.DORotate(Vector3.up * 360, 1f).SetRelative().SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
//        coinSound = GetComponent<AudioSource>();
//    }
//
//    void OnTriggerEnter(Collider other)
//    {
//        count++;
//        transform.DOLocalMoveY(transform.position.y + 2, 0.5f).SetRelative().SetEase(Ease.InOutBounce);
//        transform.DOScale(Vector3.zero, 1f).SetEase(Ease.InOutBounce).OnComplete(() => Destroy(gameObject));
//        GetComponent<Collider>().enabled = false;
//        if (coinSound != null)
//        {
//            coinSound.Play();
//        }
//    }
//    public static void ResetCoins()
//    {
//        count = 0;
//        maxCount = 0;
//
//
//        Coin[] coins = FindObjectsOfType<Coin>();
//        foreach (Coin coin in coins)
//        {
//            Destroy(coin.gameObject);
//        }
//    }
}
