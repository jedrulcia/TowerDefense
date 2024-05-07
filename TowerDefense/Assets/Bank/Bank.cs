using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 300;
    [SerializeField] int currentBalance;
    [SerializeField] TMP_Text balanceText;
    public int CurrentBalance { get { return currentBalance; } }


    void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }


    void UpdateDisplay()
    {
        balanceText.text = $"Gold: {currentBalance}";
    }

    void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance < 0)
        {
            ReloadScene();
        }
    }



}
