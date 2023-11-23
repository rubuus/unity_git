using UnityEngine;
using UnityEngine.UI;

public class JellyPanel : MonoBehaviour
{
    public int count = 0;
    public bool[] lockArray = { true, true, false, false, false, false, false, false, false, false, false, false};
    public GameObject pageText, jellyImage, jellyName, jellyPrice, lockGroup;
    public AssetArray assetArray;
    Text pageCountText, jellyNameText, jellyPriceText;
    Image jellySprite;

    private void Awake()
    {
        assetArray = FindObjectOfType<AssetArray>();

        jellySprite = jellyImage.GetComponent<Image>();
        pageCountText = pageText.GetComponent<Text>();
        jellyNameText = jellyName.GetComponent<Text>();
        jellyPriceText = jellyPrice.GetComponent<Text>();
    }

    private void Start()
    {
        jellyPriceText.text = assetArray.koj[count].price.ToString();
    }

    void Update()
    {
        if (!lockArray[count])
        {
            lockGroup.SetActive(true);
        }
        else
        {
            lockGroup.SetActive(false);
        }
    }

    public void LeftBtnClick()
    {
        if (count > 0)
        {
            count--;
            pageCountText.text = string.Format("#{0:D2}", count + 1);
            UpdateUI();
        }
    }

    public void RightBtnClick()
    {
        if (count < 11)
        {
            count++;
            pageCountText.text = string.Format("#{0:D2}", count + 1);
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        jellyNameText.text = assetArray.koj[count].jellyName.ToString();
        jellyPriceText.text = assetArray.koj[count].price.ToString();
        jellySprite.sprite = assetArray.koj[count].sprite;

        jellySprite.SetNativeSize();
    }
}
