void Test() {
    Director director = new Director();
    Product product = null;

    /*
    *   Build product A
    */
    // Building procedure is well-orgernized by director
    director.Construct( new ConcreteBuilderA() );
    product = director.GetProduct();
    product.ShowProduct();


    /*
    *   Build product A
    */
    director.Construct( new ConcreteBuilderB() );
    product = director.GetProduct();
    product.ShowProduct();
}
