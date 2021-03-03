public void FixAllGroupBoxes(Color colour)
{
    foreach (Control Control in Controls)
    {
        if (Control is GroupBox GroupBoxArea)
        {
            var ColourDictionary = new Dictionary<string, Color>();

            foreach (Control SubControl in GroupBoxArea.Controls)
            {
                ColourDictionary[SubControl.Name] = SubControl.ForeColor;
            }

            GroupBoxArea.ForeColor = colour;

            foreach (Control SubControl in GroupBoxArea.Controls)
            {
                if (ColourDictionary.ContainsKey(SubControl.Name))
                {
                    SubControl.ForeColor = ColourDictionary[SubControl.Name];
                }
            }
        }
    }
}
