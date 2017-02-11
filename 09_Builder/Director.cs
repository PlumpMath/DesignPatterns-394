public class Director {
    private Product m_product;

    /*
    *   Construct a product type depends on builder.
    *   Only design order here.
    */
    void ConstructProduct( Builder builder ) {
        m_product = new Product();
        builder.BuildPart1( m_product );
        builder.BuildPart2( m_product );
    }
    void GetProduct() { return m_product; }
}
