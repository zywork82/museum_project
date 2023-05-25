using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArtTitle : MonoBehaviour
{
    public TMP_Text artName;

    public void ChangeTitleTheAmbassadors()
    {
        artName.text = "The Ambassadors";
    }

    public void ChangeTitleJudithBeheadingHolofernes()
    {
        artName.text = "Judith Beheading Holofernes";
    }

    public void ChangeTitleWithAPearlEarring()
    {
        artName.text = "Girl With a Pearl Earring";
    }
}