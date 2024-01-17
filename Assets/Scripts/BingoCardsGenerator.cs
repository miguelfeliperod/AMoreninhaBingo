using System;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class BingoCardsGenerator : MonoBehaviour
{
    [SerializeField] GameObject bingoCardPrefab;
    [SerializeField] GameObject bingoCardsContent;
    [SerializeField] int numberOfBingoCards;
    [SerializeField] int numberOfWordsPerBingoCard;

    void Start()
    {
        CreateBingoCardButtons();
    }

    private List<string> SetBingoCardWords(int cardNumber)
    {
        List<string> wordsList = new();
        for (int wordNumber = 0, offset = 1; wordNumber < numberOfWordsPerBingoCard; wordNumber++, offset += (1 + (cardNumber / WordsList.Words.Count)))
            wordsList.Add(WordsList.Words[((cardNumber % WordsList.Words.Count) + offset) % WordsList.Words.Count]);

        print(string.Join("\n", wordsList));
        return wordsList;
    }

    private void CreateBingoCardButtons()
    {
        for(int cardNumber = 0; cardNumber < numberOfBingoCards; cardNumber++)
        {
            BingoCardData bingoCardData = Instantiate(bingoCardPrefab, bingoCardsContent.transform).GetComponentInChildren<BingoCardData>();
            bingoCardData.SetInitialValues(cardNumber + 1, SetBingoCardWords(cardNumber));
        }
    }
}
