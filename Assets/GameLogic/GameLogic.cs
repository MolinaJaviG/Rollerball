using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    [SerializeField] GameObject JuegoLogico;

    public PlayableDirector timel_final;
    // Start is called before the first frame update
    void Start()
    {
        timel_final.stopped += timel_Final;
    }

    // Update is called once per frame
    void Update()
    {
        if (Coin.count == 0)
        {
            JuegoLogico.SetActive(true);
        }
    }

    public void timel_Final(PlayableDirector timel_final)
    {
        Coin.count = 0;
        Coin.maxCount = 0;

        SceneManager.LoadScene("SampleScene");
    }
}