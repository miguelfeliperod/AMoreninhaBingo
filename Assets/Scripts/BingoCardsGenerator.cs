using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BingoCardsGenerator : MonoBehaviour
{
    [SerializeField] GameObject bingoCardPrefab;
    [SerializeField] GameObject bingoCardsContent;
    [SerializeField] int maxNumberOfBingoCards;
    [SerializeField] int numberOfWordsPerBingoCard;

    List<List<string>> wordsGroups = new List<List<string>>();
    List<List<string>> bingoWordLists = new List<List<string>>();

    void Start()
    {
        CreateWordGroups();
        InstantiateBingoCardButtons();
    }

    private void CreateWordGroups()
    {
        // Inicializa listas de grupos de palavras
        for (int groupIndex = 0; groupIndex < numberOfWordsPerBingoCard; groupIndex++)
            wordsGroups.Add(new List<string>());

        for (int wordIndex = 0; wordIndex < WordsList.Words.Count; wordIndex++)
            wordsGroups[wordIndex % numberOfWordsPerBingoCard].Add(WordsList.Words[wordIndex]);

        foreach(var list in wordsGroups)
        print(string.Join("\n", list));

        CreateAllBingoCardLists();
    }

    private void CreateAllBingoCardLists()
    {
        // Inicializa listas palavras para cada cartela
        for (int bingoCardIndex = 0; bingoCardIndex < maxNumberOfBingoCards; bingoCardIndex++)
            bingoWordLists.Add(new List<string>());

        // Seta valores auxiliares
        int totalNumberOfWords = WordsList.Words.Count;
        int numberOfGroups = numberOfWordsPerBingoCard;
        int wordsPerGroup = totalNumberOfWords / numberOfGroups;
        int offsetToNextNumberRepetition = wordsGroups[0].Count;

        // Preenche listas com as palavras variadas
        for (int groupIndex = 0; groupIndex < numberOfGroups; groupIndex++)
        {
            int maxNumberOfEachWord = (int)(Math.Ceiling((double)maxNumberOfBingoCards / (double)wordsGroups[groupIndex].Count));
            for(int bingoWordListIndex = 0; bingoWordListIndex <  maxNumberOfBingoCards; bingoWordListIndex++)
            {
                bingoWordLists[bingoWordListIndex] = wordsGroups[bingoWordListIndex % wordsGroups.Count];
            }
        }
        foreach (List<string> list in bingoWordLists)
            print(string.Join("\n", list));
    }

    private void InstantiateBingoCardButtons()
    {
        for (int cardNumber = 0; cardNumber < maxNumberOfBingoCards; cardNumber++)
        {
            BingoCardData bingoCardData = Instantiate(bingoCardPrefab, bingoCardsContent.transform).GetComponentInChildren<BingoCardData>();
            //bingoCardData.SetInitialValues(cardNumber + 1, );
        }
    }
}
