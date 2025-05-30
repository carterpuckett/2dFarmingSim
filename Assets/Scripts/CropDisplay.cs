using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CropDisplay : MonoBehaviour
{
    public CropController.CropType crop;
    public Image cropImage;
    public TMP_Text cropText;

    public void UpdateDisplay()
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        cropImage.sprite = info.finalCrop;
        cropText.text = "x" + info.cropAmount;
    }
}
