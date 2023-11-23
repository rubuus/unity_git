using UnityEngine;
using UnityEngine.UI;

public class JellyPanel : MonoBehaviour
{
    public int count = 0;
    public bool[] unlockArray = { true, true, false, false, false, false, false, false, false, false, false};
    public GameObject prefabToInstantiate, pageText, jellyImage, jellyName, jellyPrice, lockGroup, lockJellyImage, lockJellyPrice;
    public AssetArray assetArray;
    Text pageCountText, jellyNameText, jellyPriceText, lockJellyPriceText;
    Image jellySprite, lockJellySprite;

    private void Awake()
    {
        assetArray = FindObjectOfType<AssetArray>();

        jellySprite = jellyImage.GetComponent<Image>();
        pageCountText = pageText.GetComponent<Text>();
        jellyNameText = jellyName.GetComponent<Text>();
        jellyPriceText = jellyPrice.GetComponent<Text>();

        lockJellySprite = lockJellyImage.GetComponent<Image>();
        lockJellyPriceText = lockJellyPrice.GetComponent<Text>();
    }

    private void Start()
    {
        jellyPriceText.text = assetArray.koj[count].price.ToString();
    }

    void Update()
    {

    }

    public void LeftBtnClick()
    {
        if (count > 0)
        {
            count--;
            pageCountText.text = string.Format("#{0:D2}", count + 1);
            UpdateUI(unlockArray[count]);
        }
    }

    public void RightBtnClick()
    {
        if (count < 11)
        {
            count++;
            pageCountText.text = string.Format("#{0:D2}", count + 1);
            UpdateUI(unlockArray[count]);
        }
    }

    private void UpdateUI(bool unlockCheck)
    {
        if (unlockCheck)
        {
            lockGroup.SetActive(false);

            jellyNameText.text = assetArray.koj[count].jellyName.ToString();
            jellyPriceText.text = assetArray.koj[count].price.ToString();
            jellySprite.sprite = assetArray.koj[count].sprite;

            jellySprite.SetNativeSize();
        }
        else
        {
            lockGroup.SetActive(true);

            lockJellyPriceText.text = assetArray.koj[count].lockPrice.ToString();
            lockJellySprite.sprite = assetArray.koj[count].sprite;

            lockJellySprite.SetNativeSize();
        }
    }

    public void CreateJelly()
    {
        GameObject spawedPrefab = Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
        Jelly jellyScript = spawedPrefab.GetComponent<Jelly>();
        jellyScript.ID = count;
    }
}
