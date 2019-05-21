import axios from 'axios';

export const HTTP = axios.create({
    baseURL: `http://idtp376.synerzipune.local:9015/api/`,
    headers: {
        Authorization: 'Bearer {token}'
    }
})