namespace GymClub
{
    public class Equipment
    {
        private int equipmentID;
        private string name;
        private bool isAvailable;

        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public Equipment(int equipmentID, string name, bool isAvailable)
        {
            this.equipmentID = equipmentID;
            this.name = name;
            this.isAvailable = isAvailable;
        }
    }
}
