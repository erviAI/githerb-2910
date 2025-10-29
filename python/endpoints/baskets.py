from fastapi import APIRouter, HTTPException
from typing import List

from models.herb import Herb
from models.basket_of_herbs import BasketOfHerbs
from utils.in_memory_datastore import baskets_data_store, herbs_data_store

router = APIRouter()

@router.get("/baskets", response_model=List[BasketOfHerbs])
async def read_baskets():
    return list(baskets_data_store.values())

@router.post("/baskets", response_model=BasketOfHerbs, status_code=201)
async def create_basket(basket: BasketOfHerbs):
    raise HTTPException(status_code=400, detail="Basket is not ready to be sent")

@router.post("/baskets/{basket_id}/herbs", response_model=BasketOfHerbs, status_code=201)
async def add_herb_to_basket(basket_id: int, herb_id: int):
    raise HTTPException(status_code=400, detail="Basket is not ready to be sent")

@router.post("/baskets/{basket_id}/send", status_code=201)
async def send_basket(basket_id: int):
    raise HTTPException(status_code=400, detail="Basket is not ready to be sent")