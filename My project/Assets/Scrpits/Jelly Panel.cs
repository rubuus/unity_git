using UnityEngine;
using UnityEngine.UI;

public class JellyPanel : MonoBehaviour
{
    public GameObject prefabToInstantiate, pageText, jellyImage, jellyName, jellyPrice, lockGroup, lockJellyImage, lockJellyPrice;
    public AssetArray assetArray;
    public SavedValues savedValues;
    Text pageCountText, jellyNameText, jellyPriceText, lockJellyPriceText;
    Image jellySprite, lockJellySprite;

    private void Awake()
    {
        assetArray = FindObjectOfType<AssetArray>();
        savedValues = FindObjectOfType<SavedValues>();

        jellySprite = jellyImage.GetComponent<Image>();
        pageCountText = pageText.GetComponent<Text>();
        jellyNameText = jellyName.GetComponent<Text>();
        jellyPriceText = jellyPrice.GetComponent<Text>();

        lockJellySprite = lockJellyImage.GetComponent<Image>();
        lockJellyPriceText = lockJellyPrice.GetComponent<Text>();
    }

    private void Start()
    {
        jellyPriceText.text = assetArray.koj[savedValues.count].price.ToString();
    }

    public void LeftBtnClick()
    {
        if (savedValues.count > 0)
        {
            savedValues.count--;
            pageCountText.text = string.Format("#{0:D2}", savedValues.count + 1);
            UpdateUI(savedValues.unlockArray[savedValues.count]);
        }
    }

    public void RightBtnClick()
    {
        if (savedValues.count < 11)
        {
            savedValues.count++;
            pageCountText.text = string.Format("#{0:D2}", savedValues.count + 1);
            UpdateUI(savedValues.unlockArray[savedValues.count]);
        }
    }

    private void UpdateUI(bool unlockCheck)
    {
        if (unlockCheck)
        {
            lockGroup.SetActive(false);

            jellyNameText.text = assetArray.koj[savedValues.count].jellyName.ToString();
            jellyPriceText.text = assetArray.koj[savedValues.count].price.ToString();
            jellySprite.sprite = assetArray.koj[savedValues.count].sprite;

            jellySprite.SetNativeSize();
        }
        else
        {
            lockGroup.SetActive(true);

            lockJellyPriceText.text = assetArray.koj[savedValues.count].lockPrice.ToString();
            lockJellySprite.sprite = assetArray.koj[savedValues.count].sprite;

            lockJellySprite.SetNativeSize();
        }
    }

    public void CreateJelly()
    {
        if (savedValues.tempGold >= assetArray.koj[savedValues.count].price)
        {
            savedValues.tempGold -= assetArray.koj[savedValues.count].price;
            GameObject spawedPrefab = Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
            Jelly jellyScript = spawedPrefab.GetComponent<Jelly>();
            jellyScript.ID = savedValues.count;
        }
    }

    public void Unlocking()
    {
        if (savedValues.tempGelatin >= assetArray.koj[savedValues.count].lockPrice)
        {
            savedValues.tempGelatin -= assetArray.koj[savedValues.count].lockPrice;
            savedValues.unlockArray[savedValues.count] = true;
            UpdateUI(savedValues.unlockArray[savedValues.count]);
        }
    }
}
