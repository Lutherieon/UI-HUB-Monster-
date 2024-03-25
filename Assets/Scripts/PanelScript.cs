using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject descriptionPanel, aboutPanel, attrabituesPanel, attackPanel, extraPanel;

    private void Start()
    {
        descriptionPanel.SetActive(false);
        aboutPanel.SetActive(false);
        attrabituesPanel.SetActive(false);
        attackPanel.SetActive(false);
        extraPanel.SetActive(false);
    }
    public void OpenDescriptionPanel()
    {
        descriptionPanel.SetActive(true);
        aboutPanel.SetActive(false);
        attrabituesPanel.SetActive(false);
        attackPanel.SetActive(false);
        extraPanel.SetActive(false);
    }

    public void OpenAboutPanel()
    {
        descriptionPanel.SetActive(false);
        aboutPanel.SetActive(true);
        attrabituesPanel.SetActive(false);
        attackPanel.SetActive(false);
        extraPanel.SetActive(false);
    }

    public void ShowAttrabituesPanel()
    {
        descriptionPanel.SetActive(false);
        aboutPanel.SetActive(false);
        attrabituesPanel.SetActive(true);
        attackPanel.SetActive(false);
        extraPanel.SetActive(false);

    }
    public void ShowAttackPanel()
    {
        descriptionPanel.SetActive(false);
        aboutPanel.SetActive(false);
        attrabituesPanel.SetActive(false);
        attackPanel.SetActive(true);
        extraPanel.SetActive(false);

    }
    public void ShowExtraPanel()
    {
        descriptionPanel.SetActive(false);
        aboutPanel.SetActive(false);
        attrabituesPanel.SetActive(false);
        attackPanel.SetActive(false);
        extraPanel.SetActive(true);

    }


}
