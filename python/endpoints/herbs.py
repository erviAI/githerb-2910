from fastapi import APIRouter
from typing import List
from models.herb import Herb
from utils.in_memory_datastore import herbs_data_store

router = APIRouter()

@router.get("/herbs", response_model=List[Herb])
async def read_herbs():
    return herbs_data_store