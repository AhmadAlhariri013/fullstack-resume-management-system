import axios from "axios";
import { baseUrl } from "../constants/UrlConstants";

const httpModule = axios.create({
   baseURL: baseUrl,
});

export default httpModule;