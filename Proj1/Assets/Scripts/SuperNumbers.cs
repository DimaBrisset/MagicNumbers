using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SuperNumbers : MonoBehaviour
{
    public TextMeshProUGUI AmountLable;
    public TextMeshProUGUI GameContinuedLable;
    public TextMeshProUGUI CalcClickLabel;
    public Button OneButton;
    public Button TwoButton;
    public Button TreeButton;
    public Button FourButton;
    public Button FiveButton;
    public Button SixButton;
    public Button SevenButton;
    public Button EightButton;
    public Button NineButton;
    public Button StartButton;

    [SerializeField] private int _calculatedPlayerSum;
    [SerializeField] private int _calculatedPlayerSteps;
    [SerializeField] private int _gameContinueToNumber = 50;

    void Start()
    {
        OneButton.onClick.AddListener(OneButtonClicked);
        TwoButton.onClick.AddListener(TwoButtonClicked);
        TreeButton.onClick.AddListener(TreeButtonClicked);
        FourButton.onClick.AddListener(FourButtonClicked);
        FiveButton.onClick.AddListener(FiveButtonClicked);
        SixButton.onClick.AddListener(SixButtonClicked);
        SevenButton.onClick.AddListener(SevenButtonClicked);
        EightButton.onClick.AddListener(EightButtonClicked);
        NineButton.onClick.AddListener(NineButtonClicked);
        StartButton.onClick.AddListener(StartButtonClicked);
    }


    #region MyRegion

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            OneButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TwoButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TreeButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            FourButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            FiveButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SixButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SevenButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            EightButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            NineButtonClicked();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartButtonClicked();
        }
    }

    private void OneButtonClicked()
    {
        ShowTotalSum(1);
    }

    private void TwoButtonClicked()
    {
        ShowTotalSum(2);
    }

    private void TreeButtonClicked()
    {
        ShowTotalSum(3);
    }

    private void FourButtonClicked()
    {
        ShowTotalSum(4);
    }

    private void FiveButtonClicked()
    {
        ShowTotalSum(5);
    }

    private void SixButtonClicked()
    {
        ShowTotalSum(6);
    }

    private void SevenButtonClicked()
    {
        ShowTotalSum(7);
    }

    private void EightButtonClicked()
    {
        ShowTotalSum(8);
    }

    private void NineButtonClicked()
    {
        ShowTotalSum(9);
    }

    #endregion

    private void ShowTotalSum(int numbersFromUserInput)
    {
        if (_calculatedPlayerSum <= _gameContinueToNumber)
        {
            _calculatedPlayerSum += numbersFromUserInput;
            _calculatedPlayerSteps++;
            SetAmountLableText($"Amount: {_calculatedPlayerSum}");
            SetCalculatedStep($"Step {_calculatedPlayerSteps}");
            SetGameContinuedText($"Max Summ only {_gameContinueToNumber}");
        }
        else
        {
            SetGameContinuedText($"GAME OVER. Max Summ only {_gameContinueToNumber}");
        }
    }

    private void SetAmountLableText(string text)
    {
        Debug.Log(text);
        AmountLable.text = text;
    }

    private void SetGameContinuedText(string text)
    {
        Debug.Log(text);
        GameContinuedLable.text = text;
    }

    private void SetCalculatedStep(string text)
    {
        Debug.Log(text);
        CalcClickLabel.text = text;
    }

    private void StartButtonClicked()
    {
        _calculatedPlayerSteps = 0;
        _calculatedPlayerSum = 0;
        SetCalculatedStep("Step ");
        SetAmountLableText("Amount:");
        SetGameContinuedText($"Max Summ only {_gameContinueToNumber}");
        SetCalculatedStep("Step:");
    }
}