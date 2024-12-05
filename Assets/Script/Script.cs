using UnityEngine;
using UnityEngine.UI;
public class Script : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }

    public void ButtonClick()
    {
        PlayerPrefs.SetInt("money", money++);
    }

    void Update()
    {
        moneyText.text = PlayerPrefs.GetInt("money").ToString();
    }
}