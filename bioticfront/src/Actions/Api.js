import axios from 'axios';

const baseUrl = "https://localhost:5001/api";

export default {
    bioticUser(url = baseUrl + 'bioticusers') {
        return {
            fetchAll: () => axios.get(url),
            fetchyId: id => axios.get(url + id),
            create: newRecord => axios.post(url, newRecord),
            update: (id, updateRecord) => axios.put(url + id, updateRecord),
            delete: id => axios.delete(id)
        }
    }
}