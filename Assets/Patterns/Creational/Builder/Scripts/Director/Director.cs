using UnityEngine;

namespace Patterns.Builder
{
    public sealed class Director : MonoBehaviour
    {
        [SerializeField] private Dish dish;

        [Header("Buns")]
        [SerializeField] private TopBun topBun;
        [SerializeField] private BottomBun bottomBun;

        [Header("Meats")]
        [SerializeField] private Chicken chicken;
        [SerializeField] private Beacon beacon;
        [SerializeField] private Beef beef;

        [Header("Vegetables")]
        [SerializeField] private Tomato tomato;
        [SerializeField] private Cucumder cucumder;
        [SerializeField] private Onion onion;

        [Header("Greens")]
        [SerializeField] private Salad salad;
        
        [Header("Chesees")]
        [SerializeField] private Cheddar cheddar;
        [SerializeField] private Guada guada;


        private BurgerBuilder<Hamburger> hamburgerBuilder;
        private BurgerBuilder<Chickenburger> chikenburgerBuilder;

        private void Awake()
        {
            hamburgerBuilder = new HamburgerBuilder(beef, cheddar, salad, tomato, onion, bottomBun, topBun);
            chikenburgerBuilder = new ChickenburgerBuilder(topBun, bottomBun, chicken, salad);
        }

        public void CreateChickenburger() => Extensions.IfFalse(dish.HasProduct,() => dish.Place(chikenburgerBuilder.Build()));
        public void CreateHamburgerburger() => Extensions.IfFalse(dish.HasProduct, () => dish.Place(hamburgerBuilder.Build()));

        public void Delete() => dish.Clean();
    }
}
