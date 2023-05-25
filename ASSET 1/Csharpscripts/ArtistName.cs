using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArtistName : MonoBehaviour
{
    public TMP_Text aText;

    public void ChangeArtistTheAmbassadors()
    {
        aText.text = "Hans Holbein the Younger, 1533";
    }
    public void ChangeArtistJudith()
    {
        aText.text = "Artemisia Gentileschi , 1612-1613";
    }
    public void ChangeArtistPearlGirl()
    {
        aText.text = "Johannes Vermeer, 1665";
    }
}
