using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public int tempGelatin, ID, level, exp;
    float waitTime, speedX, speedY, leftX, rightX, topY, botY;
    bool isInitializedX = false, isInitializedY = false;

    public RuntimeAnimatorController[] animatorControllers;

    public AssetArray assetArray;
    public GameObject topLeft, bottomRight;

    Animator anim;
    SpriteRenderer rend;

    void Awake()
    {
        tempGelatin = 1000;

        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

        waitTime = Random.Range(2f, 5f);
    }

    void Start()
    {
        GameObject gameManagerObject = GameObject.Find("Game Manager");
        assetArray = gameManagerObject.GetComponent<AssetArray>();

        topLeft = GameObject.Find("TopLeft");
        bottomRight = GameObject.Find("BottomRight");

        leftX = topLeft.transform.position.x;
        rightX = bottomRight.transform.position.x;
        topY = topLeft.transform.position.y;
        botY = bottomRight.transform.position.y;

        transform.position = GetRandomPosition();
    }

    void Update()
    {
        if (anim.GetBool("isWalk"))
        {
            if (!isInitializedX)
            {
                InitializationX();
                isInitializedX = true;
            }
            if (!isInitializedY)
            {
                InitializationY();
                isInitializedY = true;
            }
            StartCoroutine(Move());
        }
        else
        {
            StartCoroutine(Timer());
        }

        if (speedX > 0)
            rend.flipX = false;
        else if(speedX < 0)
            rend.flipX = true;
        else rend.flipX = false;

        if (leftX > transform.position.x || rightX < transform.position.x)
        {
            isInitializedX = false;
        }

        if (topY < transform.position.y || botY > transform.position.y)
        {
            isInitializedY = false;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            tempGelatin += 100000;
        }

        UpdateSprite();
        UpdateAnimatorController();
    }

    void UpdateSprite()
    {
        if (ID >= 0 && ID < assetArray.koj.Length)
        {
            rend.sprite = assetArray.koj[ID].sprite;
        }
    }

    void UpdateAnimatorController()
    {
        if (level >= 0 && level < animatorControllers.Length)
        {
            anim.runtimeAnimatorController = animatorControllers[level];
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(waitTime);
        anim.SetBool("isWalk", true);
    }

    IEnumerator Move()
    {
        transform.Translate(new Vector3(speedX * Time.deltaTime, speedY * Time.deltaTime, speedY * Time.deltaTime));
        yield return new WaitForSeconds(waitTime);
        anim.SetBool("isWalk", false);
        isInitializedX = false;
        isInitializedY = false;
    }

    void InitializationX()
    {
        if (leftX > transform.position.x)
            speedX = Random.Range(0, 0.5f);
        else if(rightX < transform.position.x)
            speedX = Random.Range(-0.5f, 0);
        else
            speedX = Random.Range(-0.8f, 0.8f);
    }
    void InitializationY()
    {
        if (topY < transform.position.y)
            speedY = Random.Range(-0.5f, 0);
        else if (botY > transform.position.y)
            speedY = Random.Range(0, 0.5f);
        else
            speedY = Random.Range(-0.8f, 0.8f);
    }
    Vector2 GetRandomPosition()
    {
        Vector2 basePosition = transform.position;
        Vector2 size = new Vector2(-leftX + rightX, -botY + topY);

        //x, y�� ���� ��ǥ ���
        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + 3 + Random.Range(-size.y / 2f, size.y / 2f - 1);

        Vector2 spawnPos = new Vector2(posX, posY);

        return spawnPos;
    }
}
