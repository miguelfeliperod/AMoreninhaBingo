using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BingoCardData : MonoBehaviour
{
    [SerializeField] int bingoCardNumber;
    [SerializeField] List<string> wordsList;
    [SerializeField] TextMeshProUGUI cardNumberText;

    public void SetInitialValues(int cardNumber, List<string> words)
    {
        bingoCardNumber = cardNumber;
        wordsList = new List<string>(words);

        cardNumberText.text = cardNumber.ToString();
    }
}
