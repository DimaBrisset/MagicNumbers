using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI CalcClickLable;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;
    public Button StartButton;

    [SerializeField] public int Min = 1;
    [SerializeField] public int Max = 1000;
    private int _guess;
    private int _calculatedClick = 0;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        StartButton.onClick.AddListener(StartButtonClicked);

        SetInfoText($"Загадай число от {Min} до {Max}.");
        CalculateGuess();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartButtonClicked();
        }
    }

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;
        SetGuessText($"Твое число: {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        Debug.Log(text);
        GuessLabel.text = text;
    }

    private void SetCalculatedStep(string text)
    {
        Debug.Log(text);
        CalcClickLable.text = text;
    }

    private void MoreButtonClicked()
    {
        Debug.Log("Число больше");
        Min = _guess;
        CalculateGuess();
        _calculatedClick++;
    }

    private void StartButtonClicked()
    {
        Debug.Log("Старт");
        //SetGuessText(" ");
        SetCalculatedStep(" ");
        _calculatedClick = 0;
        Min = 1;
        Max = 1000;
        CalculateGuess();
    }

    private void FinishButtonClicked()
    {
        SetGuessText($"Победа! Твое число: {_guess}");
        SetCalculatedStep($"Число ходов {_calculatedClick}");
        Debug.Log($"Число ходов {_calculatedClick}");
    }

    private void LessButtonClicked()
    {
        Debug.Log("Число меньше");
        Max = _guess;
        CalculateGuess();
        _calculatedClick++;
    }
}