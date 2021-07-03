using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tile : MonoBehaviour
{
	public bool MergedThisTurn = false;
	public int indRow;
	public int indCol;


	public int Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
			if(number == 0)
			{
				SetEmpty();
			}
			else
			{
				ApplyStyle(number);
				SetVisible();
			}
		}
	}

	private int number;

	private Text TileText;
	private Image TileImage;
	private Animator anim;


	void Awake()
	{
		anim = GetComponent<Animator>();
		TileText = GetComponentInChildren<Text>();
		TileImage = transform.Find("NumberedCell").GetComponent<Image>();
	}


	public void PlayMergeAnimation()
	{
		anim.SetTrigger("Merge");
	}

	public void PlayAppearAnimation()
	{
		anim.SetTrigger("Appear");
	}


	void ApplyStyleFromFolder(int index)
	{
		TileText.text = TileStyleFolder.Instance.TileStyles[index].Number.ToString();
		TileText.color = TileStyleFolder.Instance.TileStyles[index].TextColor;
		TileImage.color = TileStyleFolder.Instance.TileStyles[index].TileColor;
	}

	void ApplyStyle(int num)
	{
		switch(num)
		{
			case 2:
				ApplyStyleFromFolder(0);
				break;
			case 4:
				ApplyStyleFromFolder(1);
				break;
			case 8:
				ApplyStyleFromFolder(2);
				break;
			case 16:
				ApplyStyleFromFolder(3);
				break;
			case 32:
				ApplyStyleFromFolder(4);
				break;
			case 64:
				ApplyStyleFromFolder(5);
				break;
			case 128:
				ApplyStyleFromFolder(6);
				break;
			case 256:
				ApplyStyleFromFolder(7);
				break;
			case 512:
				ApplyStyleFromFolder(8);
				break;
			case 1024:
				ApplyStyleFromFolder(9);
				break;
			case 2048:
				ApplyStyleFromFolder(10);
				break;
			case 4096:
				ApplyStyleFromFolder(11);
				break;
			default:
				Debug.LogError("Check the numbers");
				break;
		}
	}

	private void SetVisible()
	{
		TileImage.enabled = true;
		TileText.enabled = true;
	}

	private void SetEmpty()
	{
		TileImage.enabled = false;
		TileText.enabled = false;
	}


	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}

