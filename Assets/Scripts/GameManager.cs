using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    Score score;

    public Score Score { get => score; }

    void Awake()
    {
        instance = this;
    }
}
