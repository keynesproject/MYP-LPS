using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPS.View.Extension
{
    public static class ComBoxExtension
    {
        public static void SetSelectItem(this ComboBox cb, object Item)
        {
            try
            {
                string select_this_item = Item.ToString();
                string item_text = "";
                int i = 0;
                for (i = 0; i < cb.Items.Count; i++)
                {
                    item_text = cb.GetItemText(cb.Items[i]);
                    if (item_text == select_this_item)
                    {
                        cb.SelectedItem = (object)cb.Items[i];
                        break;
                    }
                }
            }
            catch(Exception)
            {

            }

        }
    }
}
