public class Product {
    List < string > m_PartList = new List < string >;
    public void AddPart(string part) {
        m_PartList.Add(part);
    }
    public void ShowProduct() {
        foreach(string part in m_PartList) {
            print part;
        }
    }
}
