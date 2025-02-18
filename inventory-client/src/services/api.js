import axios from "axios";

const API_BASE_URL = "http://localhost:5094/api"; // Adjust this if needed

// API Calls for Products
export const fetchProducts = async () => {
    const response = await axios.get(`${API_BASE_URL}/product`);
    return response.data;
};

export const addProduct = async (product) => {
    const response = await axios.post(`${API_BASE_URL}/product`, product);
    return response.data;
};

export const updateProduct = async (id, product) => {
    const response = await axios.put(`${API_BASE_URL}/product/${id}`, product);
    return response.data;
};

export const deleteProduct = async (id) => {
    await axios.delete(`${API_BASE_URL}/product/${id}`);
};

// API Calls for Warehouses
export const fetchWarehouses = async () => {
    const response = await axios.get(`${API_BASE_URL}/warehouses`);
    return response.data;
};

export const addWarehouse = async (warehouse) => {
    const response = await axios.post(`${API_BASE_URL}/warehouses`, warehouse);
    return response.data;
};

export const updateWarehouse = async (id, warehouse) => {
    const response = await axios.put(`${API_BASE_URL}/warehouses/${id}`, warehouse);
    return response.data;
};

export const deleteWarehouse = async (id) => {
    await axios.delete(`${API_BASE_URL}/warehouses/${id}`);
};
