using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class store : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Backgrounds";
    public Sprite[] backgrounds;
 
 
    void Awake()
    {
        if (resourceName != "SmoothStone")
        backgrounds = Resources.LoadAll<Sprite> (resourceName);
    }
 
 
    public void OnClickChangeBackground()
    {
 
        if (currentSprite == 0)
        {
                        GameObject.Find ("Panel").GetComponent<Image> ().sprite = backgrounds [currentSprite];
                        currentSprite++;
 
                } else if (currentSprite == 1) {
                        GameObject.Find ("Panel").GetComponent<Image> ().sprite = backgrounds [currentSprite];
                        currentSprite++;
                } else if (currentSprite == 2) {
                        GameObject.Find ("Panel").GetComponent<Image> ().sprite = backgrounds [currentSprite];
                        currentSprite++;
                } else if (currentSprite == 3) {
                        GameObject.Find ("Panel").GetComponent<Image> ().sprite = backgrounds [currentSprite];
                        currentSprite = 0;
                }
 
        }
}