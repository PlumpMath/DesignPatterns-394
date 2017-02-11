void Test() {
    FlyweightFactory flyweightFactory = new FlyweightFactory();
    //Create Shared Flyweights
    flyweightFactory.GetSharedFlyweight("1", "shared 1");
    flyweightFactory.GetSharedFlyweight("2", "shared 2");
    flyweightFactory.GetSharedFlyweight("3", "shared 3");

    //Create an Unshared Flyweight
    Flyweight sharedflyweight = flyweightFactory.GetSharedFlyweight("1", "");
    UnsharedConcreteFlyweight unsharedFlyweight_A = flyweightFactory.GetUnsharedFlyweight("1");
    unsharedFlyweight_A.SetSharedFlyweight(sharedflyweight);

    //Create another Unshared Flyweight
    UnsharedConcreteFlyweight unsharedFlyweight_B = new UnsharedConcreteFlyweight("1", "", "2");
}

/*
    Shared Container
    [ 1 ]   //  shared by sharedFlyweight, unsharedFlyweight_A and unsharedFlyweight_B;
    [ 2 ]
    [ 3 ]
