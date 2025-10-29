import pytest
from models.herb import Herb
from models.basket_of_herbs import BasketOfHerbs

@pytest.fixture
def herb():
    return Herb(id=1, name="Cilantro")

def test_empty_basket_not_ready(herb):
    basket = BasketOfHerbs(id=1, herbs=[])
    assert not basket.is_ready_to_send()