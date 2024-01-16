using System;
using UnityEngine;

public class BingoCardsGenerator : MonoBehaviour
{
    [SerializeField] GameObject bingoCardPrefab;
    [SerializeField] int numberOfBingoCards;
    [SerializeField] int numberOfWordsPerBingoCard;

    void Start()
    {
        CreateBingoCardButtons();
    }

    private void SetBingoCardWords(int cardNumber)
    {
        for (int wordNumber = 0; wordNumber < numberOfWordsPerBingoCard; wordNumber++)
        {

        }
    }

    private void CreateBingoCardButtons()
    {
        for(int cardNumber = 0; cardNumber < numberOfBingoCards; cardNumber++)
        {
            Instantiate(bingoCardPrefab);
            SetBingoCardWords(cardNumber);
        }
    }
}
